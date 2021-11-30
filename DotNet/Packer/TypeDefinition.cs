﻿namespace DotNetJS.Packer
{
    public class TypeDefinition
    {
        public string FileName { get; }
        public string Source { get; }

        public TypeDefinition (string fileName, string source)
        {
            FileName = fileName;
            Source = source;
        }
    }
}
