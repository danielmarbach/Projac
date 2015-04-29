﻿using System;
using NUnit.Framework;

namespace Projac.Tests
{
    [TestFixture]
    public class ResolveTests
    {
        [Test]
        public void WhenHandlerMessageTypeHandlersCanNotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
                Resolve.WhenHandlerMessageType(null));
        }

        [Test]
        public void WhenHandlerMessageTypeResolverThrowsWhenMessageIsNull()
        {
            var sut = Resolve.WhenHandlerMessageType(new SqlProjectionHandler[0]);
            Assert.Throws<ArgumentNullException>(() => sut(null));
        }

        [TestCaseSource(typeof(HandlerResolutionCases), "WhenHandlerMessageTypeCases")]
        public void WhenHandlerMessageTypeResolverReturnsExpectedResult(
            SqlProjectionHandler[] resolvable,
            object message,
            SqlProjectionHandler[] resolved)
        {
            var sut = Resolve.WhenHandlerMessageType(resolvable);
            var result = sut(message);
            Assert.That(result, Is.EquivalentTo(resolved));
        }

        [Test]
        public void WhenAssignableToHandlerMessageTypeHandlersCanNotBeNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
                Resolve.WhenAssignableToHandlerMessageType(null));
        }

        [Test]
        public void WhenAssignableToHandlerMessageTypeResolverThrowsWhenMessageIsNull()
        {
            var sut = Resolve.WhenAssignableToHandlerMessageType(new SqlProjectionHandler[0]);
            Assert.Throws<ArgumentNullException>(() => sut(null));
        }

        [TestCaseSource(typeof(HandlerResolutionCases), "WhenAssignableToHandlerMessageTypeCases")]
        public void WhenAssignableToHandlerMessageTypeResolverReturnsExpectedResult(
            SqlProjectionHandler[] resolvable,
            object message,
            SqlProjectionHandler[] resolved)
        {
            var sut = Resolve.WhenAssignableToHandlerMessageType(resolvable);
            var result = sut(message);
            Assert.That(result, Is.EquivalentTo(resolved));
        }
    }
}
