using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RubyFlavor
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Object/i/yield_self.html
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T YieldSelf<T>(this T obj, Action<T> action)
        {
            action.Invoke(obj);
            return obj;
        }

        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Object/i/yield_self.html
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T YieldSelf<T>(this T obj, Func<T, object> action)
        {
            action.Invoke(obj);
            return obj;
        }

        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Object/i/tap.html
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T Tap<T>(this T obj, Action<T> action) => obj.YieldSelf<T>(action);

        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Object/i/tap.html
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static T Tap<T>(this T obj, Func<T, object> action) => obj.YieldSelf<T>(action);
    }
}
