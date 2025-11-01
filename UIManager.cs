using System;
using System.Collections.Generic;

namespace UIManagement
{
    public static class UIManager
    {
        private readonly static Dictionary<Type, BaseWindow> _windows;

        static UIManager()
        {
            _windows = new();
        }

        public static void Register(BaseWindow window)
        {
            Type type = window.GetType();

            if (!_windows.TryAdd(type, window))
                throw new RegistrationException($"Window already registred: {type.ToString()}");
        }

        public static void Show<T>() where T : BaseWindow => Show<T>(true);
        public static void Hide<T>() where T : BaseWindow => Show<T>(false);

        private static void Show<T>(bool state) where T : BaseWindow
        {
            var window = GetWindow<T>();

            window.gameObject.SetActive(state);
        }

        private static BaseWindow GetWindow<T>() where T : BaseWindow
        {
            Type type = typeof(T);

            try
            {
                return _windows[type];
            }
            catch
            {
                throw new RegistrationException($"Window not registred: {type.ToString()}");
            }
        }
    }
}