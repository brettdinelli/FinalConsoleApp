using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    internal interface IDataMapper<T> // T is the generic type, don't know what kind of type we want right now
    {
        /*
            T in <T> 
            a generic typer parameter that allows you to specify an 
            arbitrary type "T" to a method at compile time, without
            specifying a concrete type in the method or class declaration
            this is an example of loosely coupling
        */

        List<T> Select();
        List<T> Find(string LastName);

    }
}
