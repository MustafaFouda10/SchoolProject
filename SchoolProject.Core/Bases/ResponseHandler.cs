﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Bases
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {

        }

        public Response<T> Deleted<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.OK, //200
                Succeeded = true,
                Message = "Deleted Successfully"
            };
        }

        public Response<T> Success<T>(T entity, object meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                Meta = meta,
                StatusCode = System.Net.HttpStatusCode.OK, //200
                Succeeded = true,
                Message = "Added Successfully"
            };
        }

        public Response<T> UnAuthorized<T>()
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized, //401
                Succeeded = true,
                Message = "Unauthorized"
            };
        }

        public Response<T> BadRequest<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest, //400
                Succeeded = false,
                Message = message == null ? "Bad Request" : message
            };
        }

        public Response<T> NotFound<T>(string message = null)
        {
            return new Response<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound, //404
                Succeeded = false,
                Message = message == null ? "Not Found" : message
            };
        }

        public Response<T> Created<T>(T entity, object meta = null)
        {
            return new Response<T>()
            {
                Data = entity,
                Meta = meta,
                StatusCode = System.Net.HttpStatusCode.Created, //201
                Succeeded = true,
                Message = "Created"
            };
        }

    }
}
