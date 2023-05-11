using ComposeBuilderDotNet.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComposeBuilderDotNet.Model
{
    public class Logging : ObjectBase
    {
        public string Driver
        {
            get => GetProperty<string>("driver");
            set => SetProperty("driver", value);
        }

        public LoggingsJsonFileOptions Options
        {
            get => GetProperty<LoggingsJsonFileOptions>("options");
            set => SetProperty("options", value);
        }
    }
}
