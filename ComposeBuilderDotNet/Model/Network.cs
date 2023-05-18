using System;
using ComposeBuilderDotNet.Model.Base;

namespace ComposeBuilderDotNet.Model
{
    [Serializable]
    public class Network : ObjectBase
    {
    }

    [Serializable]
    public class DefaultNetwork:ObjectBase
    {
          public Network Default
        {
            get => GetProperty<Network>("default");
            set => SetProperty("default", value);
        }
    }

}