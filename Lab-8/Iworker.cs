using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8
{
    interface Iworker
    {
        string Name { get; }

        string Surname { get; }

        string Patronymic { get; }

        string Position { get; }

        int Age { get; }
    }
}
