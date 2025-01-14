﻿using System.Net;

namespace Noghte.BuildingBlock.Exceptions;

public class AppException : Exception
{
    public HttpStatusCode HttpStatusCode { get; set; }
    public ConsumerStatusCode ApiStatusCode { get; set; }
    public object AdditionalData { get; set; }

    public AppException()
        : this(ConsumerStatusCode.ServerError)
    {
    }

    public AppException(ConsumerStatusCode statusCode)
        : this(statusCode, null)
    {
    }

    public AppException(string message)
        : this(ConsumerStatusCode.ServerError, message)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message)
        : this(statusCode, message, HttpStatusCode.InternalServerError)
    {
    }

    public AppException(string message, object additionalData)
        : this(ConsumerStatusCode.ServerError, message, additionalData)
    {
    }

    public AppException(ConsumerStatusCode statusCode, object additionalData)
        : this(statusCode, null, additionalData)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, object additionalData)
        : this(statusCode, message, HttpStatusCode.InternalServerError, additionalData)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, HttpStatusCode httpStatusCode)
        : this(statusCode, message, httpStatusCode, null)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, HttpStatusCode httpStatusCode,
        object additionalData)
        : this(statusCode, message, httpStatusCode, null, additionalData)
    {
    }

    public AppException(string message, Exception exception)
        : this(ConsumerStatusCode.ServerError, message, exception)
    {
    }

    public AppException(string message, Exception exception, object additionalData)
        : this(ConsumerStatusCode.ServerError, message, exception, additionalData)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, Exception exception)
        : this(statusCode, message, HttpStatusCode.InternalServerError, exception)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, Exception exception, object additionalData)
        : this(statusCode, message, HttpStatusCode.InternalServerError, exception, additionalData)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, HttpStatusCode httpStatusCode,
        Exception exception)
        : this(statusCode, message, httpStatusCode, exception, null)
    {
    }

    public AppException(ConsumerStatusCode statusCode, string message, HttpStatusCode httpStatusCode,
        Exception exception, object additionalData)
        : base(message, exception)
    {
        ApiStatusCode = statusCode;
        HttpStatusCode = httpStatusCode;
        AdditionalData = additionalData;
    }
}