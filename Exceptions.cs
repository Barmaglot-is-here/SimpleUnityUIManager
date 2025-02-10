using System;

namespace UIManagement
{

	[Serializable]
	public class WindowAlreadyRegistredException : Exception
	{
		public WindowAlreadyRegistredException() { }
		public WindowAlreadyRegistredException(string message) : base(message) { }
		public WindowAlreadyRegistredException(string message, Exception inner) : base(message, inner) { }
		protected WindowAlreadyRegistredException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	[Serializable]
	public class WindowNotRegistredException : Exception
	{
		public WindowNotRegistredException() { }
		public WindowNotRegistredException(string message) : base(message) { }
		public WindowNotRegistredException(string message, Exception inner) : base(message, inner) { }
		protected WindowNotRegistredException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	[Serializable]
	public class ComponentNotFoundException : Exception
	{
		public ComponentNotFoundException() { }
		public ComponentNotFoundException(Type type) : base(type.ToString()) { }
		public ComponentNotFoundException(string message) : base(message) { }
		public ComponentNotFoundException(string message, Exception inner) : base(message, inner) { }
		protected ComponentNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}

	[Serializable]
	public class WindowNotFoundException : Exception
	{
		public WindowNotFoundException() { }
		public WindowNotFoundException(Type type) : base(type.ToString()) { }
		public WindowNotFoundException(string message) : base(message) { }
		public WindowNotFoundException(string message, Exception inner) : base(message, inner) { }
		protected WindowNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}