#region Libraries
using FSMDomain.Concrete_States;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#endregion

namespace FSMDomain.extensions
{
    public static class StringExtensions
    {
        public static bool IsLlenandoAgua(this string value)
        {
            if (value.Equals(MachineStates.Llenar.ToString())) return true;

            return false;
        }

        public static bool IsExprimiendoAgua(this string value)
        {
            if (value.Equals(MachineStates.Exprimir_agua.ToString())) return true;

            return false;
        }

        public static bool IsEnjuagando(this string value)
        {
            if (value.Equals(MachineStates.Enjuagar.ToString())) return true;

            return false;
        }

        public static bool IsExprimiendoJabon(this string value)
        {
            if (value.Equals(MachineStates.Exprimir_jabon.ToString())) return true;

            return false;
        }

        public static bool IsApagado(this string value)
        {
            if (value.Equals(MachineStates.Apagar.ToString())) return true;

            return false;
        }
    }
}
