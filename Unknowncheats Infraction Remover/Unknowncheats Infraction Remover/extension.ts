//purpose of this file: prototype for javaquery injection
function main(): void {
    var HTMLPage: string = null;
    var StartIndex = 0, EndIndex = 0, InfractionOffset = 0;
    var IsRemoved: boolean = false;
    HTMLPage = document.documentElement.innerHTML;
    if (HTMLPage.search('Latest Infractions Received') != 0) {
        InfractionOffset = HTMLPage.indexOf('Latest Infractions Received');
        var stringToRemove: string = null;
        StartIndex = HTMLPage.lastIndexOf('<table', InfractionOffset);
        EndIndex = HTMLPage.indexOf('</table>', InfractionOffset) + 8;
        for (var i = StartIndex; i <= EndIndex; i++) {
            stringToRemove = stringToRemove.concat(stringToRemove, HTMLPage.charAt(i));
        }
        HTMLPage.replace(stringToRemove, null);
        IsRemoved = true;
        alert('Infractions successfully removed');
        return;
    }
    alert('wow ur such a huge virgin for not having infractions');
}

var htmlpage
htmlpage = document.documentElement.innerHTML
var startindex, endindex, infractionoffset
infractionoffset = htmlpage.search('Latest Infractions Received')
var stringtoremove
startindex = htmlpage.lastIndexOf('<table', infractionoffset)
endindex = htmlpage.indexOf('</table>', infractionoffset) + 8
stringtoremove = htmlpage.substr(startindex, endindex)
document.documentElement.innerHTML = document.documentElement.innerHTML.replace(stringtoremove, '')