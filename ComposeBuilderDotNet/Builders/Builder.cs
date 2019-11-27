﻿namespace ComposeBuilderDotNet.Builders
{
    public class Builder
    {
        public static ServiceBuilder MakeService()
        {
            return new ServiceBuilder();
        }

        public static ServiceBuilder MakeService(string serviceName)
        {
            return new ServiceBuilder().WithName(serviceName);
        }

        public static ComposeBuilder MakeCompose()
        {
            return new ComposeBuilder();
        }

        public static ComposeBuilder MakeCompose(string version)
        {
            return new ComposeBuilder().WithVersion(version);
        }

        public static VolumeBuilder MakeVolume()
        {
            return new VolumeBuilder();
        }

        public static VolumeBuilder MakeVolume(string name)
        {
            return new VolumeBuilder().WithName(name);
        }

        public static NetworkBuilder MakeNetwork()
        {
            return new NetworkBuilder();
        }

        public static NetworkBuilder MakeNetwork(string name)
        {
            return new NetworkBuilder().WithName(name);
        }

        public static MapBuilder MakeMap()
        {
            return new MapBuilder();
        }

        public static MapBuilder MakeMap(string name)
        {
            return new MapBuilder().WithName(name);
        }

        public static DeployBuilder MakeDeploy()
        {
            return new DeployBuilder();
        }
    }
}