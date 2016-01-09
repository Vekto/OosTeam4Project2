using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace TravelDatabase
{
    [PublicAPI]
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public abstract class AuthorAttribute : Attribute
    {
        public abstract string Name { get; }
    }

    public sealed class DevinAttribute : AuthorAttribute
    {
        public override string Name => "Devin";
    }

    public sealed class ChadAttribute : AuthorAttribute
    {
        public override string Name => "Chad";
    }

    public sealed class HeidiAttribute : AuthorAttribute
    {
        public override string Name => "Heidi";
    }

    public sealed class EjAttribute : AuthorAttribute
    {
        public override string Name => "EJ";
    }
}
