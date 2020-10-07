# YouTubeTimeLineGenerator
It's quite painful to make TimeLines for videos. In recent years, YouTube had developed quite a strong technology on recognizing human voice in English. It is becoming more and more accurate on words, but it still can't decide where a sentence should be separated. The advantage of the VTT subtitle is, it contains every timestamp for each words, and we can surly use that. And with human to decide where it should be a new sentence, it's a great time saver to just click the end word of a sentence, and generate a bunch of ASS subtitles in amazing ease, not mentioning if you make TimeLines by yourself, it will be surely out of sync with the YouTube ones, and the result is disaster: some of the words is missing by the end of a line, and some words appears by the beginning. With this tool, you can forget that fuzz for ever.

## Usage
Download VTT Auto-subtitles using youtube-dl. Find more: https://rg3.github.io/youtube-dl/<br />
VTT Usage: youtube-dl --skip-download --write-auto-sub --sub-format vtt http://youtube.com/xxxx<br />
XML Usage: Openup a YouTube video, then Press F12, type timedtext, then download the file.<br />
<br />
Once loaded, click the loaded words, which will be the last one in a sentance.<br />
<br />
If you find this useful, please consider supporting me. Alipay: xbox2xbox#gmail.com<br />
My website is http://sofronio.cn , and the latest version will be there. Have a good day.<br />

## Change log

### v.0.0.3.4
Fix sometimes one word is missing

### v.0.0.3.1
Fix can't display whole UI, change to tablelayout

### v.0.0.3
Add YouTube XML support, now you can get it by F12 of your browser. See usage above

### v.0.0.2
Change listbox to richtextbox for better viewing

### v.0.0.1
First edition


## Note
.Net 4.5 required
