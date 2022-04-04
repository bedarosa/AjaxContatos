using AjaxContatos.Domain.Entities;
using AjaxContatos.Domain.EntitiesBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxContatos.Infra.Data.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        
    }
}
