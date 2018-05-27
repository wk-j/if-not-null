using System;

namespace IfNotNull {
    public static class Extensions {
        public static TResult IfNotNull<TSource, TResult>(
            this TSource source,
            Func<TSource, TResult> func
        ) {
            if (object.ReferenceEquals(null, source)) {
                return default(TResult);
            } else {
                return func(source);
            }
        }
    }
}
