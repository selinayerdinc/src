using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace API.Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria { get; }
        List<Expression<Func<T,Object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }   //sayfada kaç tane ürün tutulacağını gösteriyor.
        int Skip { get; }   //sayfadan sayfaya geçerken kaç tane ürünü atlayacağımızı gösteriyor.
        bool IsPagingEnabled { get; }   //paging yapılsın mı yapılmasın mı ?

    }
}
