using FileMapper.FileModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileMapper.Interfaces
{
    public interface IMapper<From,To> 
        where From: IIssuable
        where To: IIssuable
    {
        List<To> Map(List<From> from);
        To Map(From from);
    }
}
