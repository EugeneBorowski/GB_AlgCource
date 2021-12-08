using System;

namespace GB_AlgCource
{
    internal interface ILesson
    {
        string Name { get; }
        string Description { get; }
        void Demo();
    }
}