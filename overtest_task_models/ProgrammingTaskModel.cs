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

public class ProgrammingTaskModel
{
    [JsonPropertyName("identifier")]
    /* > */public Guid Id { get; set; }
    [JsonPropertyName("title")]
    /* > */public string Title { get; set; }
    [JsonPropertyName("author")]
    /* > */public string Author { get; set; }
    [JsonPropertyName("difficulty")]
    /* > */public int Difficulty { get; set; }
}
