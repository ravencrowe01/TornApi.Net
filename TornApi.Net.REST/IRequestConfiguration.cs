﻿namespace TornApi.Net.REST {
    public interface IRequestConfiguration {
        string? Comment { get; set; }
        DateTime? From { get; set; }
        int ID { get; set; }
        string Key { get; set; }
        int? Limit { get; set; }
        string Section { get; set; }
        IEnumerable<string> Selections { get; set; }
        string? Sort { get; set; }
        DateTime? To { get; set; }

        string ToString ();
    }
}