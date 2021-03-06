using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeenAccessLibrary.Models;

namespace TeenAccessLibrary
{
    public class TeenData
    {
        private readonly ISqlDataAccess _db;

        public TeenData(ISqlDataAccess db)
        {
            _db = db;
        }
        public Task<List<TeenModel>> GetTeen()
        {
            string sql = "select * from dbo.Teen";
        }
    }
}
