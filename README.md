# YouTubeVTTLinesSeparator
After you make your own timeline for YouTube video, you can use this to separate YouTube Auto VTT subtitle to ASS subtitle.


### v.0.0.1
First edition


## Note
.Net 4.5 required

## Known Issue
The judgement of whether the word time is between your timeline is base on word_time > your_timeline_start && word_time < your_timeline_end,
but it should be using Math.Abs(word_time - your_timeline_start) > a_ms_time_like_300ms, for as the youtube timeline could be a bit head of your own timeline.
<br />
<br />To prevent from this happening of losing words, you can make your timeline a bit wider, which means the it starts a bit earlier, and ends a bit later.