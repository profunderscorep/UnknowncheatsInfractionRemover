var HTMLPage = null;
var StartIndex = 0, EndIndex = 0, InfractionOffset = 0;
var IsRemoved = false;
function main() {
    GetHTMLPage();
    RemoveInfractions();
}
function GetHTMLPage() {
    HTMLPage = document.documentElement.innerHTML;
    alert(HTMLPage);
}
function FindInfractions() {
    if (HTMLPage.search("Latest Infractions Received") != 0) {
        InfractionOffset = HTMLPage.indexOf("Latest Infractions Received");
        return true;
    }
    return false;
}
function segmentOf(beginIndex, endIndex, referenceString) {
    var returnString = "";
    for (var i = beginIndex; i <= endIndex; i++) {
        returnString = returnString.concat(returnString, referenceString.charAt(i));
    }
    return returnString;
}
function RemoveInfractions() {
    if (FindInfractions()) {
        var stringToRemove = null;
        StartIndex = HTMLPage.lastIndexOf("<table", InfractionOffset);
        EndIndex = HTMLPage.indexOf("</table>", InfractionOffset) + 8;
        stringToRemove = segmentOf(StartIndex, EndIndex, HTMLPage);
        HTMLPage.replace(stringToRemove, null);
        IsRemoved = true;
        return;
    }
    alert("wow ur such a huge virgin for not having infractions");
}
//# sourceMappingURL=extension.js.map