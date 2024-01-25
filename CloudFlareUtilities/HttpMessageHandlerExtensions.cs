﻿using System.Net.Http;

namespace CloudFlareUtilities
{
    internal static class HttpMessageHandlerExtensions
    {
        public static HttpMessageHandler GetMostInnerHandler(this HttpMessageHandler self)
        {
            return self is DelegatingHandler handler
                ? handler.InnerHandler.GetMostInnerHandler()
                : self;
        }
    }
}