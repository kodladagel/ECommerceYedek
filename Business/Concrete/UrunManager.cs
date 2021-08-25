﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UrunManager:IUrunService
    {
        IUrunDal _urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }

        [ValidationAspect(typeof(UrunValidator))]
        public IResult Add(Urun urun)
        {
            
            IResult result = BusinessRules.Run(CheckIfStockCodesTheSame(urun.StokKodu));

            if (result != null)
            {
                return result;
            }

            _urunDal.Add(urun);
            return new SuccessResult(Messages.UrunEklendi);

        }

        public IResult Delete(Urun urun)
        {
            _urunDal.Delete(urun);
            return new SuccessResult(Messages.UrunSilindi);
        }

        public IDataResult<List<Urun>> GetAll()
        {
            return new SuccessDataResult<List<Urun>>(_urunDal.GetAll(), Messages.UrunlerListelendi);
        }

        public IDataResult<List<Urun>> GetAllByCategoryId(int kategoriId)
        {
            return new SuccessDataResult<List<Urun>>(_urunDal.GetAll(u=>u.KategoriId == kategoriId));
        }

        public IDataResult<Urun> GetById(int urunId)
        {
            return new SuccessDataResult<Urun>(_urunDal.Get(u => u.UrunId == urunId));
        }

        public IDataResult<List<Urun>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Urun>>(_urunDal.GetAll(u => u.PerakendeFiyati >= min && u.PerakendeFiyati <= max));
        }

        public IResult Update(Urun urun)
        {
            _urunDal.Update(urun);
            return new SuccessResult(Messages.UrunGuncellendi);
        }



        private IResult CheckIfStockCodesTheSame(string stokKodu)
        {
            var result = _urunDal.GetAll(u => u.StokKodu == stokKodu).Count;
            if (result > 0)
            {
                return new ErrorResult(Messages.AyniStokKodluUrun);
            }
            else
            {
                return new SuccessResult();
            }

        }
    }
}
