using System;

namespace DILifeSpans.Core.Models
{
    public interface ITransientService
    {
        Guid GetID();
    }

    public interface IScopedService
    {
        Guid GetID();
    }

    public interface ISingletonService
    {
        Guid GetID();
    }

    public class DIService : ITransientService, IScopedService, ISingletonService
    {
        public Guid ID { get; set; }
        public DIService()
        {
            ID = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return ID;
        }
    }
}
