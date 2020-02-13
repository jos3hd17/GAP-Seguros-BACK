using System;
using System.Linq.Expressions;
namespace policy_back.Data
{
    public class QueryParams<T>
    {
        public QueryParams(int pag, int top)
        {

        }
        public int Pag { get; set; }
        public int Top { get; set; }
        public Expression<Func<T, bool>> Where { get; set; }
        public Func<T, object> OrderBy { get; set; }
        public Func<T, object> OrderByDesc { get; set; }
    }
}
