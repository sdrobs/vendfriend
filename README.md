vendfriend

==========


VendFriend is a market analysis software for use on Gaiaonline. A demonstration video of the software can be seen here: http://vimeo.com/73043532

If you would like to build it for your own use, please contact me. I have removed a public-facing class for security reasons, so the repo you currently see will not be able to compile on its own.


==========

###Using Vendfriend / FAQ

The demo video should contain most of what you need, but if you still have questions, this should help:


Q: I can't get vendfriend to run.

First off, vendfriend only runs on windows. It is most extensively test on windows 7, but it should work on 8 and xp as well. If you are running windows and it still won't start, you will likely need to run the program as an administrator (right click, and choose run as administrator). If it still won't start, send me an email with the error code and I'll try to see if I can figure out what is wrong.


Q: Okay, it has started up. Now what do I do?

You'll need to start by creating a price datasheet. Click the button that says 'Generate tektek price data'. This will likely take around 10 minutes or so (it is downloading ALL item prices at the current market rate). You'll only have to do it this one time though. After this completes, click the button that says 'choose item data source' and choose the new file you have just created. You're almost there; choose the 'select region button', and move it on top of the 'GO' button in the marketplace. VendFriend will only update the newest incoming items when you click in this region, so it makes sense that you click the GO button at the same time. If the full vendfriend window is too big, you can choose the popout grid, which is both transparent and should allign with the listings on the page. At this point, you're ready to go!


Q: What do the colors mean when it loads the items?

Red means the item is not a good deal; Green means it is; Grey means that the item is not found in the data sheet you are using; yellow means that the item is potentially a good deal, and vendfriend is double checking to confirm.


Q: How do I use the misprice criteria section?

The min price section will mark all items below that amount as red (not a deal). It's to avoid small/insignificant misprices.

The max price section will mark all deals that cost more than the amount specified as red. Usually you will want to set this to your gold amount, so you only see deals you can afford.

The slider below that is the price percentage. Essentially it says to only mark deals as green where the current listed price is lower than the chosen percentage of the actual price. For example, if the slider was set to 75%, if an item popped up that normally cost 100k, it would only be green if the listing that popped up was under 75k.


======

### License

ALL ITEM NAMES AND REFERENCES TO GAIAONLINE FOUND WITHIN THIS SOFTWARE ARE PROPERTY OF GAIA INTERACTIVE, INC. THIS SOFTWARE MAKES NO CLAIMS TO THE OWNERSHIP OF ANY SUCH NAMES OR INTELLECTUAL PROPERTIES.



The MIT License:

Copyright (c) 2013 Scott Robinson. srobin@mit.edu;

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
'Software'), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
