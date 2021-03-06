// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using AutorestCSharpConsoleApp.Models;
using Azure;
using Azure.Core.Pipeline;

namespace AutorestCSharpConsoleApp
{
    /// <summary> The AutorestCSharpConsoleApp service client. </summary>
    public partial class AutorestCSharpConsoleAppClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AutorestCSharpConsoleAppRestClient RestClient { get; }

        /// <summary> Initializes a new instance of AutorestCSharpConsoleAppClient for mocking. </summary>
        protected AutorestCSharpConsoleAppClient()
        {
        }

        /// <summary> Initializes a new instance of AutorestCSharpConsoleAppClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal AutorestCSharpConsoleAppClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new AutorestCSharpConsoleAppRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="value"> The ModelClass to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ModelClassTest>> OperationModelAsync(ModelClassTest value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutorestCSharpConsoleAppClient.OperationModel");
            scope.Start();
            try
            {
                return await RestClient.OperationModelAsync(value, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="value"> The ModelClass to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ModelClassTest> OperationModel(ModelClassTest value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AutorestCSharpConsoleAppClient.OperationModel");
            scope.Start();
            try
            {
                return RestClient.OperationModel(value, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
