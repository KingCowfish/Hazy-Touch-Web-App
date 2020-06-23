This is a repository for a website that I am building for a friend and coworker of mine who someday wishes to open her own massage business.  I chose to build it using ASP.NET MVC as I believe it will be the easiest framework to update should she want additional functionality in the future (such as an option for online booking or payments).  A couple of notes:

1: There is a good deal of filler text as my client has been busy and unable to provide proper descriptions.

2: The aesthetics are subject to some major changes as my client has not made any definitive decisions regarding it (other than the layout of the navbar).

3: I do not have any current timeline as to when this might go live as my client is hesitant to start a small business at this time.


My personal timeline regarding this project:
  
  I am hoping to be done with the services page by the end of the week (6/5), and then will proceed to start working on the contacts page.
  Other goals include refactoring code to remove less redundancies and to place more into the code behind, make the app more accessible to   mobile devices, and to prep a reviews page (should the my client eventually desire to have one).
  
Thanks and stay tuned!

Update 6/5:
Finished Services page (still feels a little flat aesthetically, but not a whole lot I can do about that until I get more feedback from the client) so now I will just need to set up a contact page and it should be all set for initial implementation.  My overall progress will begin to slow next friday as my regular work will begin back up, but I will just take that into account when making new goals.

Update 6/13:
So hit a little bit of a snag and a visual studio update completely rewrote my bootstrap fiddling (as I wanted to use boostrap for the modals, but wanted to remove the other parts that were conteracting my own Site.css) so I am going to have to find a more permanent solution.  

Otherwise, I am going to look into learning more about Azure in order to better test my contact page.  So my current goals are to rework the CSS to make my use of bootstrap more permanent and then to take a course on Azure.  Once those are done, I will update this. 

Update 6/14:
So bootstrap proved too unwieldly to maintain (I would fix something only for something else to break) so I decided to remove it.  This proved to be a better decision than I had originally intended as I realize I have far more options now and will be updating the services view with far more interesting modals.  Will begin to update once I figure out what sort of modals I want to use.  

Update 6/16:
Figured out the JavaScript so now the modals will open appropriately.  Next stop is to fix the css which is a total mess as even the code snippets that I got the idea for the modals from didn't work fully.  My hope is to get it done and cleaned by the end of the week (hopefully sooner, but we shall have to see).

Update 6/17: 
Polished the modals and they are looking pretty good.  I'd like to add text on top of them but despite my best efforts (and even with the guidance of various online tutorials), I have not gotten it to work.  I will probably post it to stack overflow if I can't figure it out on codepen.  I'd also like to make the transitions in and out of the modals to be less severe.  Besides those two things, the page is pretty much done (barring feedback from my client). 

Update 6/18:
Decided to leave the text below the buttons as putting it on top would force me to darken the images on the buttons and lose their pop.  I also added a more interesting background image to the modal windows.  Tomorrow will be about smoothing the transitions.

Update 6/20:
Made some progress in smoothing the transitions, but they still are not working the way I want them to.  I have posted my questions on overstack but have yet to receive any replies about it.  Otherwise, everything is done on the services page.  From here, I will probably start looking into Azure so that I can test my contacts page, make the contacts page actually presentable, and go about polishing up the other pages (the services page is significantly more interesting than the other pages, though part of that is due to my client not giving me the data I need to work with).

Update 6/22:
Made some big aesthetic changes which I am really happy about.  Besides learning about Azure in order to implement and test the contact page (and actually building said contacts page), the app is pretty much done.  Unfortunately, GitHub decided to explode on me and not only prevent me from pushing all of these changes to the remote repository (meaning here), but it won't even let me clone repositories.  So something is super wrong and I will be working to fix that.  Once I figure out that mess, then I will push the changes up and begin learning Azure.
