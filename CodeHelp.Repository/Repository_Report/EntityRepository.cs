using CodeHelp.Cloud.Dto.Project_Report_Dto;
using CodeHelp.Repository.Repository_Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeHelp.Repository.Repository_Report
{
   public static class EntityRepository
    {
        public static void CreateTable()
        {
            DbRepository repository = new DbRepository();
            repository.CodeFirst_CreateTable<Report>();
            repository.CodeFirst_CreateTable<User>();
        }
        public static void CreateClass(string path,string nameSpace)
        {
            DbRepository repository = new DbRepository();
            repository.DbFirst_CreateClass(path, nameSpace);
        }
    }
}
