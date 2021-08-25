using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YapilanOdemeManager : IYapilanOdemeService
    {
        IYapilanOdemeDal _yapilanOdemeDal;

        public YapilanOdemeManager(IYapilanOdemeDal YapilanOdemeDal)
        {
            _yapilanOdemeDal = YapilanOdemeDal;
        }

        public IResult Add(YapilanOdeme YapilanOdeme)
        {
            _yapilanOdemeDal.Add(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeEklendi);
        }

        public IResult Delete(YapilanOdeme YapilanOdeme)
        {
            _yapilanOdemeDal.Delete(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeSilindi);
        }

        public IDataResult<List<YapilanOdeme>> GetAll()
        {
            return new SuccessDataResult<List<YapilanOdeme>>(_yapilanOdemeDal.GetAll());
        }

        public IDataResult<List<YapilanOdeme>> GetAllByToptanciId(int toptanciId)
        {
            return new SuccessDataResult<List<YapilanOdeme>>(_yapilanOdemeDal.GetAll(y => y.ToptanciId == toptanciId));
        }

        public IDataResult<YapilanOdeme> GetById(int YapilanOdemeId)
        {
            return new SuccessDataResult<YapilanOdeme>(_yapilanOdemeDal.Get(y => y.YapilanOdemeId == YapilanOdemeId));
        }

        public IResult Update(YapilanOdeme YapilanOdeme)
        {
            _yapilanOdemeDal.Update(YapilanOdeme);
            return new SuccessResult(Messages.YapilanOdemeSilindi);
        }
    }
    }
