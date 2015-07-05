using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    /// <summary>
    /// Base Value Object class.
    /// </summary>
    /// <typeparam name="TIdentifier">Identifier Generic Type to be assigned dynamically.</typeparam>
    public class BaseVo<TIdentifier> : Domain.Models.IBaseVo<TIdentifier>
        where TIdentifier : new()
    {
        /// <summary>
        /// Gets or sets the Identifier.
        /// </summary>
        public virtual TIdentifier Id { get; set; }
    }
}
