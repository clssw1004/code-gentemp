using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace engine
{
    public static class Constants
    {
        public const String ARG_REGEX = @"\$\{[a-zA-Z_]{1,}[0-9a-zA-Z_]{1,}\}";
        public const String INCLUDE_REGEX = @"\$include\{\S{1,}\.tpl\}";
        public const String FOR_BEGIN_REGEX = @"\$for\{[a-zA-Z_]{1,}[0-9a-zA-Z_]{1,}\}";
        public const String FOR_END_REGEX = @"\$endfor\{[a-zA-Z_]{1,}[0-9a-zA-Z_]{1,}\}";

        public const String REPLACE_REGEX = @"\$(for|include|end|endfor)?\{|\}";
    }
}
