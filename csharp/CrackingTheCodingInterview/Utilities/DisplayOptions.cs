using System;
namespace Utilities
{
  [Flags]
  public enum DisplayOptions
  {
    None        = 0x0,
    ShowNull    = 0x1,
    ShowEmpty   = 0x2,
    ShowSpaces  = 0x4,
  }
}
