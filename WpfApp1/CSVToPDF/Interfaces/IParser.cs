using FileMapper.FileModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileMapper.Interfaces
{
    public interface IParser <T> where T: IIssuable
    {
        List<T> Parse(string path);
    }
}
