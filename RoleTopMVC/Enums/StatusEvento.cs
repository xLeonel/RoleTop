using System;
using System.ComponentModel;

namespace RoleTopMVC.Enums
{
    [Flags]
    public enum StatusEvento : uint
    {
        PENDENTE = 0,
        APROVADO = 1,
        REPROVADO = 2
    }
} 