# YouTubeTimeLineGenerator
It's quite painful to make TimeLines for videos. In recent years, YouTube had developed quite a strong technology on recognizing human voice in English. It is becoming more and more accurate on words, but it still can't decide where a sentence should be separated. The advantage of the VTT subtitle is, it contains every timestamp for each words, and we can surly use that. And with human to decide where it should be a new sentence, it's a great time saver to just click the end word of a sentence, and generate a bunch of ASS subtitles in amazing ease, not mentioning if you make TimeLines by yourself, it will be surely out of sync with the YouTube ones, and the result is disaster: some of the words is missing by the end of a line, and some words appears by the beginning. With this tool, you can forget that fuzz for ever.

## Usage
Download VTT Auto-subtitles using youtube-dl. Find more: https://rg3.github.io/youtube-dl/<br />
Usage: youtube-dl --skip-download --write-auto-sub --sub-format vtt http://youtube.com/xxxx<br />
Then click the loaded words, the one you click, will be the last one in a sentance.<br />

## Change log
### v.0.0.1
First edition


## Note
.Net 4.5 required
