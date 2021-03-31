# YouTubeTimeLineGenerator
It's quite painful to make TimeLines for videos. In recent years, YouTube had developed quite a strong technology on recognizing human voice in English. It is becoming more and more accurate on words, but it still can't decide where a sentence should be separated. The advantage of the VTT subtitle is, it contains every timestamp for each words, and we can surly use that. And with human to decide where it should be a new sentence, it's a great time saver to just click the end word of a sentence, and generate a bunch of ASS subtitles in amazing ease, not mentioning if you make TimeLines by yourself, it will be surely out of sync with the YouTube ones, and the result is disaster: some of the words is missing by the end of a line, and some words appears by the beginning. With this tool, you can forget that fuzz for ever.

## Usage
Download VTT Auto-subtitles using youtube-dl. Find more: https://rg3.github.io/youtube-dl/<br />
VTT Usage: youtube-dl --skip-download --write-auto-sub --sub-format vtt http://youtube.com/xxxx<br />
**Recommended** XML Usage: youtube-dl --skip-download --write-auto-sub --sub-format srv3 http://youtube.com/xxxx<br />
<br />
Drag auto-sub file to main window. Once loaded, click any word, a verticle red line will appear, which indiates a new line.<br />
<br />

## Auto line separation support Usage
Download beatshow-player-setup-0.3.0-temp.exe at https://www.wenshushu.cn/box/46h1lj5pgjw
Drag your mp4 video file to the exe, a json file will appear at the same path of your video.
Drag the json file to the corresponding text field, click button on the right.
Use the slider to adjuest effect.
Thanks to [@wudicgi](https://github.com/wudicgi)

## Change log

### v.0.0.4.0
Add auto line separation support
Fix xml support

### v.0.0.3.5
Fix missing words before domain .com

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
