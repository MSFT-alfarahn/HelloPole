using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if ANDROID

#endif

namespace HelloPole.View.CustomControls
{
    public class MyEntry : Entry
    {
        public MyEntry()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
            {
                if (view is MyEntry)
                {
#if ANDROID
    // Convert string to char array  
    string sentence = "custom";  
    char[] charArr = sentence.ToCharArray();  
        handler.PlatformView.SetText(charArr,0,6);
#elif IOS || MACCATALYST
                    handler.PlatformView.EditingDidBegin += (s, e) =>
                    {
                        handler.PlatformView.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
                    };
#elif WINDOWS
        handler.PlatformView.GotFocus += (s, e) =>
        {
            handler.PlatformView.SelectAll();
        };
#endif
                }
            });
        }
    }
}
