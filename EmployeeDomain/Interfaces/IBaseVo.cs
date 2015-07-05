using System;
namespace Domain.Models
{
    interface IBaseVo<TIdentifier>
     where TIdentifier : new()
    {
        TIdentifier Id { get; set; }
    }
}
