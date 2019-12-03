namespace AppDomainToolkit
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Static class for executing Async functions in foreign application domains.
    /// </summary>
    public static class RemoteFuncAsync
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The result type.
        /// </typeparam>
        /// <param name="domain">
        /// The domain to invoke the function in.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <returns>
        /// The Task result.
        /// </returns>
        public static Task<TResult> InvokeAsync<TResult>(AppDomain domain,
            Func<Task<TResult>> toInvoke)
        {
            if (domain == null)
                throw new ArgumentNullException(nameof(domain));
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));

            var proxy = Remote<RemoteFuncAsync<TResult>>.CreateProxy(domain);
            var tcs = new MarshalableTaskCompletionSource<TResult>();
            proxy.RemoteObject.Invoke(toInvoke, tcs);
            return tcs.Task;
        }

        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <typeparam name="T1">
        /// First argument type.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The result type.
        /// </typeparam>
        /// <param name="domain">
        /// The domain to invoke the function in.
        /// </param>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <returns>
        /// The Task result.
        /// </returns>
        public static Task<TResult> InvokeAsync<T1, TResult>(AppDomain domain, T1 arg1,
            Func<T1, Task<TResult>> toInvoke)
        {
            if (domain == null)
                throw new ArgumentNullException(nameof(domain));
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));

            var proxy = Remote<RemoteFuncAsync<T1, TResult>>.CreateProxy(domain);
            var tcs = new MarshalableTaskCompletionSource<TResult>();
            proxy.RemoteObject.Invoke(arg1, toInvoke, tcs);
            return tcs.Task;
        }

        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <typeparam name="T1">
        /// First argument type.
        /// </typeparam>
        /// <typeparam name="T2">
        /// Second argument type.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The result type.
        /// </typeparam>
        /// <param name="domain">
        /// The domain to invoke the function in.
        /// </param>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <returns>
        /// The Task result.
        /// </returns>
        public static Task<TResult> InvokeAsync<T1, T2, TResult>(AppDomain domain, T1 arg1, T2 arg2,
            Func<T1, T2, Task<TResult>> toInvoke)
        {
            if (domain == null)
                throw new ArgumentNullException(nameof(domain));
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));

            var proxy = Remote<RemoteFuncAsync<T1, T2, TResult>>.CreateProxy(domain);
            var tcs = new MarshalableTaskCompletionSource<TResult>();
            proxy.RemoteObject.Invoke(arg1, arg2, toInvoke, tcs);
            return tcs.Task;
        }

        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <typeparam name="T1">
        /// First argument type.
        /// </typeparam>
        /// <typeparam name="T2">
        /// Second argument type.
        /// </typeparam>
        /// <typeparam name="T3">
        /// Third argument type.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The result type.
        /// </typeparam>
        /// <param name="domain">
        /// The domain to invoke the function in.
        /// </param>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="arg3">
        /// The third argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <returns>
        /// The Task result.
        /// </returns>
        public static Task<TResult> InvokeAsync<T1, T2, T3, TResult>(AppDomain domain, T1 arg1, T2 arg2, T3 arg3,
            Func<T1, T2, T3, Task<TResult>> toInvoke)
        {
            if (domain == null)
                throw new ArgumentNullException(nameof(domain));
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));

            var proxy = Remote<RemoteFuncAsync<T1, T2, T3, TResult>>.CreateProxy(domain);
            var tcs = new MarshalableTaskCompletionSource<TResult>();
            proxy.RemoteObject.Invoke(arg1, arg2, arg3, toInvoke, tcs);
            return tcs.Task;
        }

        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <typeparam name="T1">
        /// First argument type.
        /// </typeparam>
        /// <typeparam name="T2">
        /// Second argument type.
        /// </typeparam>
        /// <typeparam name="T3">
        /// Third argument type.
        /// </typeparam>
        /// <typeparam name="T4">
        /// Fourth argument type.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The result type.
        /// </typeparam>
        /// <param name="domain">
        /// The domain to invoke the function in.
        /// </param>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="arg3">
        /// The third argument.
        /// </param>
        /// <param name="arg4">
        /// The fourth argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <returns>
        /// The Task result.
        /// </returns>
        public static Task<TResult> InvokeAsync<T1, T2, T3, T4, TResult>(AppDomain domain, T1 arg1, T2 arg2, T3 arg3, T4 arg4,
            Func<T1, T2, T3, T4, Task<TResult>> toInvoke)
        {
            if (domain == null)
                throw new ArgumentNullException(nameof(domain));
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));

            var proxy = Remote<RemoteFuncAsync<T1, T2, T3, T4, TResult>>.CreateProxy(domain);
            var tcs = new MarshalableTaskCompletionSource<TResult>();
            proxy.RemoteObject.Invoke(arg1, arg2, arg3, arg4, toInvoke, tcs);
            return tcs.Task;
        }

        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <typeparam name="T1">
        /// First argument type.
        /// </typeparam>
        /// <typeparam name="T2">
        /// Second argument type.
        /// </typeparam>
        /// <typeparam name="T3">
        /// Third argument type.
        /// </typeparam>
        /// <typeparam name="T4">
        /// Fourth argument type.
        /// </typeparam>
        /// <typeparam name="T5">
        /// Fifth argument type.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The result type.
        /// </typeparam>
        /// <param name="domain">
        /// The domain to invoke the function in.
        /// </param>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="arg3">
        /// The third argument.
        /// </param>
        /// <param name="arg4">
        /// The fourth argument.
        /// </param>
        /// <param name="arg5">
        /// The fifth argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <returns>
        /// The Task result.
        /// </returns>
        public static Task<TResult> InvokeAsync<T1, T2, T3, T4, T5, TResult>(AppDomain domain, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
            Func<T1, T2, T3, T4, T5, Task<TResult>> toInvoke)
        {
            if (domain == null)
                throw new ArgumentNullException(nameof(domain));
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));

            var proxy = Remote<RemoteFuncAsync<T1, T2, T3, T4, T5, TResult>>.CreateProxy(domain);
            var tcs = new MarshalableTaskCompletionSource<TResult>();
            proxy.RemoteObject.Invoke(arg1, arg2, arg3, arg4, arg5, toInvoke, tcs);
            return tcs.Task;
        }


        internal static Task Continuation<TResult>(this Task<TResult> previous, MarshalableTaskCompletionSource<TResult> tcs)
        {
            return previous.ContinueWith(t =>
            {
                if (t.IsCanceled)
                    tcs.SetCanceled();
                else if (t.IsFaulted)
                    tcs.SetException(t.Exception.InnerExceptions.ToArray());
                else
                    tcs.SetResult(t.Result);
            });
        }
    }

    /// <summary>
    /// Executes an asynchronous function in another application domain.
    /// </summary>
    /// <typeparam name="TResult">
    /// The result type.
    /// </typeparam>
    public class RemoteFuncAsync<TResult> : MarshalByRefObject
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <param name="tcs">
        /// The TaskCompletionSource to propagate Task results
        /// </param>
        public void Invoke(Func<Task<TResult>> toInvoke, MarshalableTaskCompletionSource<TResult> tcs)
        {
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));
            if (tcs == null)
                throw new ArgumentNullException(nameof(tcs));
            toInvoke.Invoke().Continuation(tcs);
        }
    }

    /// <summary>
    /// Executes an asynchronous function in another application domain.
    /// </summary>
    /// <typeparam name="T1">
    /// First argument type.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// The result type.
    /// </typeparam>
    public class RemoteFuncAsync<T1, TResult> : MarshalByRefObject
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <param name="tcs">
        /// The TaskCompletionSource to propagate Task results
        /// </param>
        public void Invoke(T1 arg1, Func<T1, Task<TResult>> toInvoke, MarshalableTaskCompletionSource<TResult> tcs)
        {
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));
            if (tcs == null)
                throw new ArgumentNullException(nameof(tcs));
            toInvoke.Invoke(arg1).Continuation(tcs);
        }
    }

    /// <summary>
    /// Executes an asynchronous function in another application domain.
    /// </summary>
    /// <typeparam name="T1">
    /// First argument type.
    /// </typeparam>
    /// <typeparam name="T2">
    /// Second argument type.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// The result type.
    /// </typeparam>
    public class RemoteFuncAsync<T1, T2, TResult> : MarshalByRefObject
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <param name="tcs">
        /// The TaskCompletionSource to propagate Task results
        /// </param>
        public void Invoke(T1 arg1, T2 arg2, Func<T1, T2, Task<TResult>> toInvoke, MarshalableTaskCompletionSource<TResult> tcs)
        {
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));
            if (tcs == null)
                throw new ArgumentNullException(nameof(tcs));
            toInvoke.Invoke(arg1, arg2).Continuation(tcs);
        }
    }

    /// <summary>
    /// Executes an asynchronous function in another application domain.
    /// </summary>
    /// <typeparam name="T1">
    /// First argument type.
    /// </typeparam>
    /// <typeparam name="T2">
    /// Second argument type.
    /// </typeparam>
    /// <typeparam name="T3">
    /// Third argument type.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// The result type.
    /// </typeparam>
    public class RemoteFuncAsync<T1, T2, T3, TResult> : MarshalByRefObject
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="arg3">
        /// The third argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <param name="tcs">
        /// The TaskCompletionSource to propagate Task results
        /// </param>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, Func<T1, T2, T3, Task<TResult>> toInvoke, MarshalableTaskCompletionSource<TResult> tcs)
        {
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));
            if (tcs == null)
                throw new ArgumentNullException(nameof(tcs));
            toInvoke.Invoke(arg1, arg2, arg3).Continuation(tcs);
        }
    }

    /// <summary>
    /// Executes an asynchronous function in another application domain.
    /// </summary>
    /// <typeparam name="T1">
    /// First argument type.
    /// </typeparam>
    /// <typeparam name="T2">
    /// Second argument type.
    /// </typeparam>
    /// <typeparam name="T3">
    /// Third argument type.
    /// </typeparam>
    /// <typeparam name="T4">
    /// Fourth argument type.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// The result type.
    /// </typeparam>
    public class RemoteFuncAsync<T1, T2, T3, T4, TResult> : MarshalByRefObject
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="arg3">
        /// The third argument.
        /// </param>
        /// <param name="arg4">
        /// The fourth argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <param name="tcs">
        /// The TaskCompletionSource to propagate Task results
        /// </param>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, Func<T1, T2, T3, T4, Task<TResult>> toInvoke, MarshalableTaskCompletionSource<TResult> tcs)
        {
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));
            if (tcs == null)
                throw new ArgumentNullException(nameof(tcs));

            toInvoke.Invoke(arg1, arg2, arg3, arg4).Continuation(tcs);
        }
    }

    /// <summary>
    /// Executes an asynchronous function in another application domain.
    /// </summary>
    /// <typeparam name="T1">
    /// First argument type.
    /// </typeparam>
    /// <typeparam name="T2">
    /// Second argument type.
    /// </typeparam>
    /// <typeparam name="T3">
    /// Third argument type.
    /// </typeparam>
    /// <typeparam name="T4">
    /// Fourth argument type.
    /// </typeparam>
    /// <typeparam name="T5">
    /// Fifth argument type.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// The result type.
    /// </typeparam>
    public class RemoteFuncAsync<T1, T2, T3, T4, T5, TResult> : MarshalByRefObject
    {
        /// <summary>
        /// Invokes the target asynchronous function.
        /// </summary>
        /// <param name="arg1">
        /// The first argument.
        /// </param>
        /// <param name="arg2">
        /// The second argument.
        /// </param>
        /// <param name="arg3">
        /// The third argument.
        /// </param>
        /// <param name="arg4">
        /// The fourth argument.
        /// </param>
        /// <param name="arg5">
        /// The fifth argument.
        /// </param>
        /// <param name="toInvoke">
        /// The function to invoke.
        /// </param>
        /// <param name="tcs">
        /// The TaskCompletionSource to propagate Task results
        /// </param>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, Func<T1, T2, T3, T4, T5, Task<TResult>> toInvoke, MarshalableTaskCompletionSource<TResult> tcs)
        {
            if (toInvoke == null)
                throw new ArgumentNullException(nameof(toInvoke));
            if (tcs == null)
                throw new ArgumentNullException(nameof(tcs));

            toInvoke.Invoke(arg1, arg2, arg3, arg4, arg5).Continuation(tcs);
        }
    }
}
