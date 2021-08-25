using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAlinanOdemeService
    {
        IDataResult<List<AlinanOdeme>> GetAll();
        IDataResult<List<AlinanOdeme>> GetAllByMusteriId(int musteriId);
        IDataResult<AlinanOdeme> GetById(int alinanOdemeId);
        IResult Add(AlinanOdeme alinanOdeme);
        IResult Update(AlinanOdeme alinanOdeme);
        IResult Delete(AlinanOdeme alinanOdeme);
    }
}
