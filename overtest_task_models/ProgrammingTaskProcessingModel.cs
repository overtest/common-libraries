/*
 * This file is a part of Overtest Common Libraries project
 * Copyright (C) 2023 Yurii Kadirov (aka Sirkadirov)
 * https://github.com/overtest/common-libraries
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 */

using System.Text.Json.Serialization;

namespace Sirkadirov.Overtest.Common.TaskModels;
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

public class ProgrammingTaskProcessingModel
{
    [JsonPropertyName("author_solution")]
    /* > */public AuthorSolution AuthorSolution { get; set; }
    [JsonPropertyName("test_scripts")]
    /* > */public TestScripts TestScripts { get; set; }
    [JsonPropertyName("config_defaults")]
    /* > */public TaskProcessingDefaults TaskProcessingDefaults { get; set; }
    [JsonPropertyName("release_testing")]
    /* > */public ReleaseTestingConfig ReleaseTestingConfig { get; set; }
}

public sealed class AuthorSolution
{
    [JsonPropertyName("compiler_id")]
    /* > */public Guid CompilerId { get; set; }
    [JsonPropertyName("source_path")]
    /* > */public string SourcePath { get; set; }
}

public sealed class TestScripts
{
    [JsonPropertyName("initializer")]
    /* > */public string InitializerScript { get; set; }
    [JsonPropertyName("finalizer")]
    /* > */public string FinalizerScript { get; set; }
    [JsonPropertyName("generator")]
    /* > */public string GeneratorScript { get; set; }
    [JsonPropertyName("checker")]
    /* > */public string CheckerScript { get; set; }
}

public class TaskProcessingDefaults
{
    [JsonPropertyName("use_author_solution")]
    /* > */public bool UseAuthorSolution { get; set; }
    [JsonPropertyName("streams_redirection")]
    /* > */ public StreamsRedirectionConfiguration StreamsRedirection { get; set; }
    [JsonPropertyName("runtime_limits")]
    /* > */ public RuntimeLimits RuntimeLimits { get; set; }
}

public sealed class StreamsRedirectionConfiguration
{
    [JsonPropertyName("stdin")]
    /* > */public string Stdin { get; set; }
    [JsonPropertyName("stdout")]
    /* > */public string Stdout { get; set; }
    [JsonPropertyName("stderr")]
    /* > */public string Stderr { get; set; }
}

public sealed class RuntimeLimits
{
    [JsonPropertyName("max_exec_time")]
    /* > */public int MaxExecutionTime { get; set; }
    [JsonPropertyName("max_proc_time")]
    /* > */public int MaxProcessorTime { get; set; }
    [JsonPropertyName("max_proc_mems")]
    /* > */public int MaxMemoryUsage { get; set; }
}

public sealed class ReleaseTestingConfig
{
    [JsonPropertyName("max_time_kills")]
    /* > */public int MaxTimeKillsCount { get; set; }
    [JsonPropertyName("verification_tests")]
    /* > */public List<SingleVerificationTestDetails> VerificationTests { get; set; }
}

public sealed class SingleVerificationTestDetails : TaskProcessingDefaults
{
    public string Title { get; set; }
}
