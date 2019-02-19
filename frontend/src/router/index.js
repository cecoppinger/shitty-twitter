import Vue from 'vue';
import Router from 'vue-router';

import HomePage from '../components/HomePage.vue';
import ShittyTweet from '../components/ShittyTweet.vue';
import PostTweet from '../components/PostTweet.vue';
import AllTweets from '../components/AllTweets.vue';

Vue.use(Router);

export default new Router({
  mode: 'history',
  routes: [{
    name: 'HomePage',
    path: '/',
    component: HomePage,
    children: [{
      name: 'AllTweets',
      path: 'all',
      component: AllTweets,
    }, {
      name: 'PostTweet',
      path: '/post',
      component: PostTweet,
    }],
  }, {
    name: 'ShittyTweet',
    path: '/shittytweet',
    component: ShittyTweet,
  }],
});
