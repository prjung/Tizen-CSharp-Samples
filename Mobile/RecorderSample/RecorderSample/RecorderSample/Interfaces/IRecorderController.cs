﻿/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace RecorderSample
{
    /// <summary>
    /// Defines methods and properties that control the recorder.
    /// </summary>
    public interface IRecorderController
    {
        /// <summary>
        /// Prepares the recorder.
        /// </summary>
        void Prepare();

        /// <summary>
        /// Starts recording.
        /// </summary>
        void Start();

        /// <summary>
        /// Stops recording and save.
        /// </summary>
        void Commit();

        /// <summary>
        /// Pauses recording.
        /// </summary>
        void Pause();

        /// <summary>
        /// Resumes recording.
        /// </summary>
        void Resume();

        /// <summary>
        /// Unprepares the recorder.
        /// </summary>
        void Unprepare();

        /// <summary>
        /// Gets the save path.
        /// </summary>
        string SavePath { get; }

        /// <summary>
        /// Gets the recorder state.
        /// </summary>
        RecorderState State { get; }
    }
}