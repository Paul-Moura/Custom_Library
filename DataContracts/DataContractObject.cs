using System;
using System.IO;
using System.Runtime.Serialization;
using Custom.Enums;

namespace Custom.DataContracts
{
	[DataContract]
	public abstract class DataContractObject
	{
		[DataMember]
		private State _state;

		public virtual bool HasChanges
		{
			get { return _state != State.Normal; }
		}

		public State State
		{
			get { return _state; }
			set
			{
				if (Modified != null) Modified(this, EventArgs.Empty);
				if (_state != State.New) _state = value;
			}
		}

		protected DataContractObject()
		{
			Initialize();
		}

		#region Methods

		public virtual void Initialize() { }

		public DataContractObject Copy()
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), GetType() + "Copy.xml");
			Xml.Serialize(path, this);
			var obj = (DataContractObject) Xml.Deserialize(path, GetType());
			if (File.Exists(path)) File.Delete(path);
			return obj;
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			Initialize();
		}
		
		#endregion

		public delegate void ModifiedEventHandler(object sender, EventArgs e);

		public event ModifiedEventHandler Modified;
	}
}
