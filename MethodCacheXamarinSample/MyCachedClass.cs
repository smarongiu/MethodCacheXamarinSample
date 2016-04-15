using System;
using MethodCache.Attributes;
using System.Collections.Generic;

namespace MethodCacheXamarinSample {
public class MyCachedClass {

	public MyCachedClass(ICache cache) {
		Cache = cache;
	}

	public ICache Cache { get; private set; }

	public string Foo { get; }

	[Cache]
	public int Add(int a, int b) {
		return a + b;
	}

}
}
