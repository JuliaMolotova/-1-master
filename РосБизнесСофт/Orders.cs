//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace РосБизнесСофт
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public int IdClients { get; set; }
        public int IdAgents { get; set; }
        public int IdService { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
    
        public virtual AgentsSet AgentsSet { get; set; }
        public virtual ClientsSet ClientsSet { get; set; }
        public virtual Service Service { get; set; }
    }
}
