using ReactNative;
using ReactNative.Modules.Core;
using ReactNative.Shell;
using RNCamera;
using System.Collections.Generic;

namespace Example
{
    class MainPage : ReactPage
    {
        public override string MainComponentName
        {
            get
            {
                return "Example";
            }
        }

#if BUNDLE
        public override string JavaScriptBundleFile
        {
            get
            {
                return "ms-appx:///ReactAssets/index.windows.bundle";
            }
        }
#endif

        public override List<IReactPackage> Packages
        {
            get
            {
                return new List<IReactPackage>
                {
                    new MainReactPackage(),
                    new RNCameraPackage(),
                };
            }
        }

        public override bool UseDeveloperSupport
        {
            get
            {
#if !BUNDLE || DEBUG
                return true;
#else
                return false;
#endif
            }
        }
    }

}
