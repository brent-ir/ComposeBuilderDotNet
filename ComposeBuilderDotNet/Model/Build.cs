using ComposeBuilderDotNet.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposeBuilderDotNet.Model
{
    [Serializable]
    public class Build: ObjectBase
    {
        public string Context
        {
            get => GetProperty<string>("context");
            set => SetProperty("context", value);
        }
        
        public string DockerFile
        {
            get => GetProperty<string>("dockerfile");
            set => SetProperty("dockerfile", value);
        }
    }
}
