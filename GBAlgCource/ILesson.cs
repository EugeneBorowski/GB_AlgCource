using System;

namespace GBAlgCource
{
    internal interface ILesson
    {
        string Name { get; }
        string Description { get; }
        void Demo();
        void Start(string input);
    }
}