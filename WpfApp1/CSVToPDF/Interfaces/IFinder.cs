using FileMapper.FileModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileMapper.Interfaces
{
    public interface IFinder<T> where T: IIssuable
    {
        bool Find(T item);
    }
}
