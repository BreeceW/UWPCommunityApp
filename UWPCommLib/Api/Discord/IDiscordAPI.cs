﻿using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using UWPCommLib.Api.Discord.Models;

namespace UWPCommLib.Api.Discord
{
    [Headers("Authorization: Bearer")]
    public interface IDiscordAPI
    {
        /// <summary>
        /// Gets the user's registered projects (requires authentication)
        /// </summary>
        [Get("/users/@me")]
        Task<User> GetCurrentUser([Authorize] string token);
    }
}
