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

namespace Sirkadirov.Overtest.Common.TaskModels;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

public class DefaultOvertestTaskStructure
{
    public const string ProjectFileName = "overtest-task.json";
    public const string ProcessingConfigFileName = "task-processing.json";
    public const string TaskDescriptionFileName = "task-description.md";

    public const string AuthorSolutionDirectoryName = "author-solution";
    public const string InitializerFileName = "initializer.py";
    public const string FinalizerFileName = "finalizer.py";
    public const string GeneratorFileName = "generator.py";
    public const string CheckerFileName = "checker.py";
}
