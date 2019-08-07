from django.contrib.auth.models import User
from django.test import TestCase
from django.urls import resolve, reverse

from ..models import Board, Post, Topic
from ..views import topic_posts
from ..views import PostListView

class TopicPostsTests(TestCase):
    def setUp(self):
        board = Board.objects.create(name='django', descriptions='django board.')
        user = User.objects.create_user(username='yves', email='', password='kigali321')
        topic = Topic.objects.create(subject='Smoking', board=board, starter=user)
        Post.objects.create(message='this is my first topic ', topic=topic, created_by=user)
        url = reverse('topic_posts', kwargs={'pk': board.pk, 'topic_pk': topic.pk})
        self.response = self.client.get(url)

    def test_status_code(self):
        self.assertEquals(self.response.status_code, 200)

    def test_view_function(self):
        view = resolve('/boards/1/topics/1/')
        self.assertEquals(view.func, topic_posts)