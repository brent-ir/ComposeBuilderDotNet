using ComposeBuilderDotNet.Model.Base;

namespace ComposeBuilderDotNet.Model
{
    public class LoggingsJsonFileOptions : ObjectBase
    {
        public string MaximumFileSize
        {
            get => GetProperty<string>("max-size");
            set => SetProperty("max-size", value);
        }

        public string MaximumFileCount
        {
            get => GetProperty<string>("max-file");
            set => SetProperty("max-file", value);
        }
    }
}
