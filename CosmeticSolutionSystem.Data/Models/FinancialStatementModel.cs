using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticSolutionSystem.Data.Models
{
    public class FinancialStatementModel
    {
        public int FinancialStatementId { get; }
        public int Year { get;}
        public int 자산 { get; }
        public int 부채 { get; }
        public int 자본 { get; }
        public int 매출액 { get; }
        public int 매출원가 { get; }
        public int 매출총이익 { get; }
        public int 판매비와관리비 { get; }
        
        public int 영업이익 { get; }
        public int 영업외손익 { get; }

        public int 당기순이익 { get; }
    }
}
