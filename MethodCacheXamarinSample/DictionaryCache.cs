using System;
using MethodCache.Attributes;
using System.Collections.Generic;

namespace MethodCacheXamarinSample {

public class DictionaryCache : ICache {
	public DictionaryCache() {
		Storage = new Dictionary<string, object>();
	}

	private Dictionary<string, object> Storage { get; set; }

	// Note: The methods Contains, Retrieve, Store (and Remove) must exactly look like the following:

	public bool Contains(string key) {
		return Storage.ContainsKey(key);
	}

	public T Retrieve<T>(string key) {
		return (T)Storage[key];
	}

	public void Store(string key, object data) {
		Storage[key] = data;
	}

	// Remove is needed for writeable properties which must invalidate the Cache
	// You can skip this method but then only readonly properties are supported
	public void Remove(string key) {
		Storage.Remove(key);
	}
}

}
