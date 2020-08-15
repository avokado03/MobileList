using FileMapper.FileModels;
using FileMapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileMapper.CsvToPdf
{
    public class CsvToPdfMapper : IMapper<CsvIssueModel, PdfIssueModel>
    {
        public List<string> Errors { get; private set; }

        private Dictionary<string, string> IssueFilePathes;

        //TODO: ctor

        public List<PdfIssueModel> Map(List<CsvIssueModel> from)
        {
            var pdfs = new List<PdfIssueModel>();
            foreach (var csv in from)
                pdfs.Add(Map(csv));
            return pdfs;
        }

        //TODO: add parsing
        public PdfIssueModel Map(CsvIssueModel from)
        {
            throw new Exception();
        }

        private string ParseCsvName(string name)
        {
            string path = "";
            //TODO: add parsing
            return path;
        }
    }
}
