using System;
using System.Collections.Generic;
using System.Text;

namespace PageOrientation
{
 
    public enum PageOrientation
    {
        Landscape,
        Portrait,
        Any
    }
    
    public interface IOrientationService
    {
        void ForceLandscapeOrientation();
        void ForcePortraitOrientation();
        void AllowAnyOrientation();
    }
}
